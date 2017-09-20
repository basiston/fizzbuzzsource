'use strict';
app.factory('fizzbuzzService', ['$http', function ($http) {

    var fizzbuzzServiceFactory = {};

    var _getvalues = function (value) {

        return $http({
            method: "GET",
            url: "/api/FizzBuzz/",
            params: {
                value: value
            }

        })
              .then(function mySucess(response) {
                  return response;
              });

    };

    fizzbuzzServiceFactory.getvalues = _getvalues;

    return fizzbuzzServiceFactory;
}]);