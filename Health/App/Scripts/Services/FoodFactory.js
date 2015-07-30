app.factory('FoodFactory', ['$http', '$q', '$location', function ($http, $q, $location) {
    var o = {};
    o.food = {};
    o.facts = [];
    o.vit = [];
    o.mealid = 1;

    //usda data
    o.getFood = function (search) {
        var defer = $q.defer();
        var config = { contentType: 'application/json' };
        $http.get('http://api.nal.usda.gov/ndb/search/?format=json&q=' + search + '&sort=n&max=25&offset=0&api_key=q7pED6v0gfqkI1YHDD8vio3VbDl2oP33oTrXpi16', config).success(function (data) {
            o.food.length = 0;
            defer.resolve(data);
            for (var i = 0; i < data.length; i++) {
                o.food[i] = data[i];
            };
        });
        return defer.promise;
    };
    o.nextPage = function (search, page) {
        var defer = $q.defer();
        var config = { contentType: 'application/json' };
        $http.get('http://api.nal.usda.gov/ndb/search/?format=json&q=' + search + '&sort=n&max=25&offset=' + page + '&api_key=q7pED6v0gfqkI1YHDD8vio3VbDl2oP33oTrXpi16', config).success(function (data) {
            o.food.length = 0;
            defer.resolve(data);
            for (var i = 0; i < data.length; i++) {
                o.food[i] = data[i];
            };
        });
        return defer.promise;
    };
    o.prevPage = function (search, page) {
        var defer = $q.defer();
        var config = { contentType: 'application/json' };
        $http.get('http://api.nal.usda.gov/ndb/search/?format=json&q=' + search + '&sort=n&max=25&offset=' + page + '&api_key=q7pED6v0gfqkI1YHDD8vio3VbDl2oP33oTrXpi16', config).success(function (data) {
            o.food.length = 0;
            defer.resolve(data);
            for (var i = 0; i < data.length; i++) {
                o.food[i] = data[i];
            };
        });
        return defer.promise;
    };
    o.getFacts = function (id) {
        var defer = $q.defer();
        var config = { contentType: 'application/json' };
        $http.get('http://api.nal.usda.gov/ndb/reports/?ndbno=' + id + '&type=b&format=json&api_key=q7pED6v0gfqkI1YHDD8vio3VbDl2oP33oTrXpi16', config).success(function (data) {
            defer.resolve(data);
            o.facts = data;
        });
        return defer.promise;
    };
    o.getVitamins = function () {
        var config = { contentType: 'application/json' };
        $http.get('api/apiFood/' + o.mealid, config).success(function (data) {
            o.vit.length = 0;
            for (i = 0; i < data.length; i++) {
                o.vit[i] = data[i];
            }
        }).error(function (data) { });
    };

    o.getVitamins();
    return o;
}]);