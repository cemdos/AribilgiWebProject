app.controller('CheckoutCtrl', function ($scope, $http) {
    $scope.GetCityList = function () {
        $scope.IsShowLoader = true;
        $http.get("/Common/GetCityList")
            .then(function (response) {
                $scope.IsShowLoader = false;
                if (response.data.IsSuccess) {
                    $scope.CityList = response.data.ResponseModel;
                }
                else {
                    alert(response.data.ErrorMessage);
                }
            });
    }

    $scope.GetSubTotal = function () {
        var subTotal = 0;
        for (var i = 0; i < $scope.ShoppingCart.length; i++) {
            var cartItem = $scope.ShoppingCart[i];
            subTotal += cartItem.Product.UnitPrice * cartItem.Quantity;
        }
        return subTotal;
    }

    $scope.SaveOrder = function () {
        alert("Merhaba");
    }

    $scope.LoadData = function () {
        $scope.GetCityList();
    }
    $scope.LoadData();
});