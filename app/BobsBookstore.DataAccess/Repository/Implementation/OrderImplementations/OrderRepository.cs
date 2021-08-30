﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using BobsBookstore.Models.Orders;
using BobsBookstore.DataAccess.Repository.Interface.OrdersInterface;
using BobsBookstore.DataAccess.Repository.Interface.SearchImplementations;
using BobsBookstore.DataAccess.Dtos;

namespace BobsBookstore.DataAccess.Repository.Implementation.OrderImplementations
{

    public class OrderRepository : IOrderRepository
    {
        /*
         * Order Repository contains all functions associated with Order Model
         */

        private readonly int _ordersPerPage = 20;
        private readonly string[] OrderIncludes = { "Customer", "Address", "OrderStatus"};
        private ISearchRepository _searchRepo;
        private IOrderDatabaseCalls _orderDbCalls;
        private IExpressionFunction _expFunc;

        // Set up connection to Database 
        public OrderRepository(ISearchRepository searchRepo, IOrderDatabaseCalls orderDbCalls, IExpressionFunction expFunc)
        {
            _searchRepo = searchRepo;
            _orderDbCalls = orderDbCalls;
            _expFunc = expFunc;
        }



        // Find Single Order by the Order Id
        public Order FindOrderById(long id)
        {
            string filterValue = "Order_Id";
            string searchString = "" + id;
            string inBetween = "";
            string operand = "==";
            string negate = "false";

            Order order = null;
            try
            {
                var query = FilterOrder(filterValue, searchString, inBetween, operand, negate);

                order = query.First();
            }
            catch (InvalidOperationException ex)
            {
                order = null;
            }



            return order;
        }

        private ManageOrderDto RetrieveDto(string filterValue, string searchString, int pageNum, int totalPages, int[] pages, List<Order> order)
        {
            var manageOrderDto = new ManageOrderDto();

            manageOrderDto.SearchString = searchString;
            manageOrderDto.FilterValue = filterValue;
            manageOrderDto.Orders = order;
            manageOrderDto.Pages = pages;
            manageOrderDto.HasPreviousPages = (pageNum > 1);
            manageOrderDto.CurrentPage = pageNum;
            manageOrderDto.HasNextPages = (pageNum < totalPages);

            return manageOrderDto;
        }


        // Find All the Orders in the Table
        public ManageOrderDto GetAllOrders(int pageNum)
        {

            ManageOrderDto viewModel = new ManageOrderDto();

            var orderBase = _orderDbCalls.GetBaseQuery("BobsBookstore.Models.Orders.Order");

            var query = _orderDbCalls.ReturnBaseQuery<Order>(orderBase, OrderIncludes);

            var totalPages = _searchRepo.GetTotalPages(query.Count(), _ordersPerPage);

            viewModel = RetrieveFilterDto(query, totalPages, pageNum, "", "");

            return viewModel;
        }


        private ManageOrderDto RetrieveFilterDto(IQueryable<Order> filterQuery, int totalPages, int pageNum, string filterValue, string searchString)
        {

            var orders = filterQuery
                            .OrderBy(order => order.OrderStatus.Position)
                            .ThenBy(order => order.DeliveryDate)
                            .Skip((pageNum - 1) * _ordersPerPage)
                            .Take(_ordersPerPage)
                            .ToList();

            int[] pages = _searchRepo.GetModifiedPagesArr(pageNum, totalPages);

            var manageOrderDto = RetrieveDto(filterValue, searchString, pageNum, totalPages, pages, orders);

            return manageOrderDto;
        }



        public ManageOrderDto FilterList(string filterValue, string searchString, int pageNum)
        {

            var parameterExpression = _expFunc.ReturnParameterExpression(typeof(Order), "Order");

            var expression = _searchRepo.ReturnExpression(parameterExpression, filterValue, searchString);

            Expression<Func<Order, bool>> lambda = _expFunc.ReturnLambdaExpression<Order>(expression, parameterExpression);

            if (lambda == null)
            {
                int[] pages = Enumerable.Range(1, 1).ToArray();


                return RetrieveDto("", "", 1, 1, pages, null);

            }
            var orderBase = _orderDbCalls.GetBaseQuery("BobsBookstore.Models.Orders.Order");

            var query = _orderDbCalls.ReturnBaseQuery<Order>(orderBase, OrderIncludes);

            var filterQuery = _orderDbCalls.ReturnFilterQuery<Order>(query, lambda);

            int totalPages = _searchRepo.GetTotalPages(filterQuery.Count(), _ordersPerPage);

            var manageOrderDto = RetrieveFilterDto(filterQuery, totalPages, pageNum, filterValue, searchString);
            return manageOrderDto;

        }


        public IQueryable<Order> FilterOrder(string filterValue, string searchString, string inBetween, string operand, string negate)
        {
            string tableName = "Order";

            Expression<Func<Order, bool>> lambda = _expFunc.ReturnLambdaExpression<Order>(tableName, filterValue, searchString, inBetween, operand, negate);

            var orderBase = _orderDbCalls.GetBaseQuery("BobsBookstore.Models.Orders.Order");

            var query = _orderDbCalls.ReturnBaseQuery<Order>(orderBase, OrderIncludes);

            var filterQuery = _orderDbCalls.ReturnFilterQuery(query, lambda);

            return filterQuery;
        }

    }
}