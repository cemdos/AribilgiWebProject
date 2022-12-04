var app = angular.module('App', []);
app.controller('LoginCtrl', function ($scope, $http) {
    $scope.UserModel = {};

    $scope.Login = function () {
        $http.get(ServiceUrl + `/Account/Login/${$scope.UserModel.UserName}/${$scope.UserModel.Password}`)
            .then(function (response) {
                if (response.access_token != null) {
                    localStorage.setItem("token", response.access_token);
                }
                else {
                    alert("Başarısız");
                }
            });
    }
});