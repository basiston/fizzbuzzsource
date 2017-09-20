'use strict';
app.controller('fizzbuzzController', ['$scope', 'fizzbuzzService', function ($scope, fizzbuzzService) {


    $scope.Fizzbuzz =
    {
        value: ''
    }

    $scope.GetValues = function (value) {
        if (value === "") {
            alert("value is null");
            return;
        }
        fizzbuzzService.getvalues(value).then(function (result) {
            $scope.result = result.data;
        }, function (error) {
            $scope.error = error.statusText;
        });

    };

    $scope.Clear = function () {
        $scope.Fizzbuzz = null;
        $scope.result = null;

    };


}]);
