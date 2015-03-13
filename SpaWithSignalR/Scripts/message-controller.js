/// <reference path="angular.min.js" />
angular.module('messageApp', [])
    .controller('messageController', function ($scope, $http) {
        $scope.send = function (message) {
            $http.post("/api/messages", message)
                .success(function (data, status, headers, config) {
                     $scope.message.Post = $scope.message.Name = '';
                });
        };
    });