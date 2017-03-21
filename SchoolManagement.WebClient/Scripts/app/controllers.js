"use strict";


/* Controllers */
angular.module("myApp")
    .controller("MyCtrl1", [
        "$scope", "$http",
        function($scope, $http) {
            $scope.students = [];
            $scope.loadData = function() {

                $http.get("http://localhost:12816/Api/Student?Get")
                    .then(function (response) {
                        $scope.students = response.data;
                    }, function(error) {
                    console.log(error);
                });
            };
            $scope.loadData();
        }
    ])
    .controller("MyCtrl2", ["$scope", "$http",
        function($scope,$http) {
            $scope.save = function (std) {
                $http({
                    method: 'POST',
                    url: 'http://localhost:12816/Api/Student/Post',
                    data: JSON.stringify(std)
                })
               .then(function (response) {
                   Console.log(response);
                   $scope.Name = '';
                   $scope.Address = '';
                   $scope.Phone = '';

                    }),function(error) {
                    Console.log(Error);
                }
            }
        }
    ]);