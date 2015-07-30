app.controller('FoodController', ['$scope', 'FoodFactory', 'AddFactory', '$routeParams', '$location', '$q', function ($scope, FoodFactory, AddFactory, $routeParams, $location, $q) {
    $scope.vit = AddFactory.vit;
    $scope.facts = FoodFactory.facts;
    $scope.rec = AddFactory.rec;
    //search stuff
    $scope.search = function (search) {
        FoodFactory.getFood(search).then(function (usdadata) {
            $scope.newfacts = usdadata;
        });
    };
    $scope.nextP = 0;
    $scope.next = function (search) {
        $scope.nextP++;
        page = $scope.nextP * 25
        FoodFactory.nextPage(search, page).then(function (usdadata) {
            $scope.newfacts = usdadata;
        });
    };
    $scope.prevP = function (search) {
        if ($scope.nextP != 0) {
            $scope.nextP--;
            page = $scope.nextP * 25
            FoodFactory.nextPage(search, page).then(function (usdadata) {
                $scope.newfacts = usdadata;
            });
        };
    };
    $scope.getInfo = function (id) {
        FoodFactory.getFacts(id).then(function (usdadata) {
            $scope.facts = usdadata;
        });
    };
    // database stuff
    $scope.add = function (send, vit) {
        AddFactory.add(send, vit).then(function (data) {
            AddFactory.getTotals(data).then(function (data) {
                $scope.vit = data
            })
        });
    };
    $scope.delete = function (id) {
        AddFactory.DeleteTotals(id).then(function (data) {
            AddFactory.delete(id).then(function (data) {
                $scope.vit = data
            })
        });
    };
}]);