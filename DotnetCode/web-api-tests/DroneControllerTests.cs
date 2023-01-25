using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using web_api.Controllers;
using Xunit;

namespace web_api_tests
{
    public class DroneControllerTest
    {
        private readonly DroneController _controller;

        public DroneControllerTest()
        {
            _controller = new DroneController();
        }

        // [Fact]
        // public void Get_WhenCalledWithEmptyList_ReturnsEmptyList()
        // {
        //     var list =_controller.GetDroneList(new List<int>());

        //     Assert.Equal(list.Count, 0);
        // }

        // [Fact]
        // public void Get_WhenCalledWithSingleItem_ReturnsItem()
        // {
        //     var list =_controller.GetDroneList(new List<int>{1});

        //     Assert.Equal(list.Count, 1);
        //     Assert.Equal(list[0], 1);
        // }

        // [Fact]
        // public void Get_WhenOneMisMatch_ReturnsMisMatch()
        // {
        //     var list =_controller.GetDroneList(new List<int>{1,2,1});

        //     Assert.Equal(list.Count, 1);
        //     Assert.Equal(list[0], 2);
        // }

        // [Fact]
        // public void Get_WhenAllMisMatch_ReturnsMisMatch()
        // {
        //     var list =_controller.GetDroneList(new List<int>{99, 34, 23});

        //     Assert.Equal(list.Count, 3);
        //     Assert.Equal(list[0], 99);
        //     Assert.Equal(list[1], 34);
        //     Assert.Equal(list[2], 23);
        // }

        // [Fact]
        // public void Get_WhenCalledWithAllPairs_ReturnsEmptyList()
        // {
        //     var list =_controller.GetDroneList(new List<int>{1,2,3,4,4,2,1,3,4,4});

        //     Assert.Equal(list.Count, 0);
        // }
    }
}
