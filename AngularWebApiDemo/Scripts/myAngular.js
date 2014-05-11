var myDemoApp = angular.module('myDemoApp', []);

myDemoApp.controller('PageController', ['$scope', '$http', function ($scope, $http) {
    $http.get('/api/Values').success(function(data){
        $scope.Model = data;
    });

    $scope.OnCountrySelected = function () {
        alert('fn called');
        $scope.CountrySelected = true;
    };
}]);