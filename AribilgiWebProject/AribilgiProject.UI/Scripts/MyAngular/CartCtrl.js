app.controller('CartCtrl', function ($scope, $http) {
    $scope.ApplyCoupon = function (CouponCode) {
        $scope.IsShowLoader = true;
        var paramsItem = {
            CouponCode: CouponCode
        }

        $http.get("/Coupon/GetCheckCoupon", { params: paramsItem })
            .then(function (response) {
                if (response.data.IsSuccess) {
                    alert("Kupon Başarıyla uygulandı");
                }
                else {
                    alert(response.data.ErrorMessage);
                }
                $scope.IsShowLoader = false;
            });
    }
});