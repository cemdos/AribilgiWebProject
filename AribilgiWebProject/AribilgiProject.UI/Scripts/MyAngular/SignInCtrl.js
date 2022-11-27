app.controller('SignInCtrl', function ($scope, $http, toaster) {
    $scope.UserModel = {};
    $scope.LoginModel = {};
    $scope.AddressModel = {};

    $scope.GetLocalStoreData = function () {
        var LSActiveUser = localStorage.getItem("ActiveUser");
        if (LSActiveUser != null && LSActiveUser != "") {
            $scope.ActiveUser = JSON.parse(LSActiveUser);
        }
        else
            $scope.ActiveUser = null;
    }
    $scope.GetLocalStoreData();


    $scope.RegisterUser = function () {
        $scope.IsShowLoader = true;
        $http.get("/User/RegisterUser", { params: $scope.UserModel })
            .then(function (response) {
                $scope.IsShowLoader = false;
                if (response.data.ResponseCode == 1) {
                    //toaster.pop("success","Bilgi", "Kayıt işlemi başarılı..");
                    alert("Kayıt işlemi başarılı..");
                }
                else if (response.data.ResponseCode == 3) {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("warning","Uyarı", response.data.ErrorMessage);
                }
                else {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("error","Hata", response.data.ErrorMessage);
                }

            });
    }

    $scope.LoginUser = function () {
        $scope.IsShowLoader = true;
        $http.get("/User/LoginUser", { params: $scope.LoginModel })
            .then(function (response) {
                $scope.IsShowLoader = false;
                if (response.data.ResponseCode == 1) {
                    localStorage.setItem("ActiveUser", JSON.stringify(response.data.ResponseModel))
                    $scope.ActiveUser = response.data.ResponseModel;
                    //toaster.pop("success","Bilgi", "Kayıt işlemi başarılı..");
                    alert("Login Başarılı");
                }
                else if (response.data.ResponseCode == 3) {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("warning","Uyarı", response.data.ErrorMessage);
                }
                else {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("error","Hata", response.data.ErrorMessage);
                }

            });
    }

    $scope.SaveAddress = function () {
        $scope.IsShowLoader = true;
        $http.get("/User/SaveAddress", { params: $scope.AddressModel })
            .then(function (response) {
                $scope.IsShowLoader = false;
                if (response.data.ResponseCode == 1) {
                    alert("Kayıt Başarılı");
                }
                else if (response.data.ResponseCode == 3) {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("warning","Uyarı", response.data.ErrorMessage);
                }
                else {
                    alert(response.data.ErrorMessage);
                    //toaster.pop("error","Hata", response.data.ErrorMessage);
                }

            });
    }
});