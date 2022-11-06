var app = angular.module('App', []);
app.controller('BaseCtrl', function ($scope, $http) {
    $scope.IsShowLoader = false;

    $scope.GetAllCategory = function () {
        $scope.IsShowLoader = true;
        $http.get("/Category/GetAllCategory")
            .then(function (response) {
                if (response.data.IsSuccess) {
                    var FullCategoryList = response.data.ResponseModel;
                    $scope.CategoryList = FullCategoryList.filter(_ => _.ParentId == null);
                    for (var i = 0; i < $scope.CategoryList.length; i++) {
                        $scope.CategoryList[i].ChildCategory =
                            FullCategoryList.filter(_ => _.ParentId == $scope.CategoryList[i].ID)
                    }
                }
                else {
                    alert(response.data.ErrorMessage);
                }
                $scope.IsShowLoader = false;
            });
    }

    $scope.GetAllCategory();
});