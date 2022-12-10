var app = angular.module('App', []);
app.controller('BaseCtrl', function ($scope, $http) {
    function TokenControl() {
        var token = localStorage.getItem("token");
        if (token == null || token == "") {
            window.location.href = "/admin/login";
        }
        $scope.Token = token;
    }
    TokenControl();

    $scope.Logout = function () {
        localStorage.removeItem("token");
        window.location.href = "/admin/login";
    }
});