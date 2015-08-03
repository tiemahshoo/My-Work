app.controller('FoodController', ['$scope', 'FoodFactory', 'AddFactory', '$routeParams', 'UserFactory', '$location', '$q', function ($scope, FoodFactory, AddFactory, $routeParams, UserFactory, $location, $q) {
    $scope.vit = AddFactory.vit;
    $scope.facts = FoodFactory.facts;
    $scope.rec = AddFactory.rec;
    $scope.yourfood = AddFactory.yourfood;
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
                $scope.rec = AddFactory.rec;
                $scope.vit = data;
                AddFactory.getlist().then(function (data) {
                    $scope.yourfood = data;
                });
            });
        });
    };
    $scope.delete = function (id) {
        AddFactory.DeleteTotals(id).then(function (data) {
            $scope.rec = AddFactory.rec;
            AddFactory.delete(id).then(function () {
                AddFactory.getlist().then(function (data) {
                    $scope.yourfood = data;
                });
            });
        });
    };
    $scope.addMeal = function (id, loggedin) {
        if (loggedin = true) {
            var mealname = prompt("What's your meal's name?")
            AddFactory.addMeal(id, mealname);
        }
        else alert('Please Log-in First.')
    };
}]);