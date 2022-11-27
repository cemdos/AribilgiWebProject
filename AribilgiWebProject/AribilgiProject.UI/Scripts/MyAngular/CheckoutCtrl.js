app.controller('CheckoutCtrl', function ($scope, $http) {
    $scope.Order = {};
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

    $scope.GetCouponInfo = function () {
        var CouponCode = localStorage.getItem("CouponCode");
        if (CouponCode == null)
            return;

        $scope.IsShowLoader = true;
        var paramsItem = {
            CouponCode: CouponCode
        }
        $http.get("/Coupon/GetCheckCoupon", { params: paramsItem })
            .then(function (response) {
                if (response.data.IsSuccess) {
                    $scope.Coupon = response.data.ResponseModel;
                }
                $scope.IsShowLoader = false;
            });
    }

    $scope.GetDiscount = function () {
        var subTotal = $scope.GetSubTotal();
        var DiscountPercent = 0;
        if ($scope.Coupon != null)
            DiscountPercent = $scope.Coupon.DiscountPercent;
        return subTotal * DiscountPercent / 100;
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
        var OrderDetailModel = [];
        for (var i = 0; i < $scope.ShoppingCart.length; i++) {
            OrderDetailModel.push({
                ProductId: $scope.ShoppingCart[i].Product.ID,
                Quantity: $scope.ShoppingCart[i].Quantity
            })
        }

        $scope.IsShowLoader = true;
        var paramsItem = {
            Order: JSON.stringify($scope.Order),
            OrderDetail: JSON.stringify(OrderDetailModel)
        }
        $http.get("/Order/CreateOrder", { params: paramsItem })
            .then(function (response) {
                if (response.data.IsSuccess) {
                    alert("Sipariş Olustu.");
                }
                else
                    alert(response.data.ErrorMessage);
                $scope.IsShowLoader = false;
            });
    }

    $scope.LoadData = function () {
        $scope.GetCityList();
        $scope.GetCouponInfo();
    }
    $scope.LoadData();
});