var app = angular.module('App', []);
app.controller('LoginCtrl', function ($scope, $http) {
    $scope.UserModel = {};

    $scope.Login = function () {
        $http.get(ServiceUrl + `/Account/Login/${$scope.UserModel.UserName}/${$scope.UserModel.Password}`)
            .then(function (response) {
                if (response.data.access_token != null) {
                    localStorage.setItem("token", response.data.access_token);
                    window.location.href = "/admin/index";
                }
                else {
                    alert("Başarısız");
                }
            });
    }
});