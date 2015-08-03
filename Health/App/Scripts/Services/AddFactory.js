app.factory('AddFactory', ['$http', '$q', '$location', function ($http, $q, $location) {
    var o = {};
    o.vit = [];
    o.yourfood = [];
    o.mealID = [];
    o.rec = [];
    o.deleted = [];
    o.calcium = { nutrient_id: 301, value: 1000, unit: "mg", name: "Calcium, Ca", totalvitamins: 0, percent: 0 };
    o.copper = { nutrient_id: 312, value: 900, unit: "ug", name: "Copper, Cu", totalvitamins: 0, percent: 0 };
    o.fluoride = { nutrient_id: 313, value: 4, unit: "mg", name: "Fluoride, F", totalvitamins: 0, percent: 0 };
    o.folic = { nutrient_id: 431, value: 400, unit: "ug", name: "Folic acid", totalvitamins: 0, percent: 0 };
    o.iron = { nutrient_id: 303, value: 8, unit: "mg", name: "Iron, Fe", totalvitamins: 0, percent: 0 };
    o.magnesium = { nutrient_id: 304, value: 400, unit: "mg", name: "Magnesium, Mg", totalvitamins: 0, percent: 0 };
    o.manganese = { nutrient_id: 315, value: 2.3, unit: "mg", name: "Manganese, Mn", totalvitamins: 0, percent: 0 };
    o.phosphorus = { nutrient_id: 305, value: 700, unit: "mg", name: "Phosphorus, P", totalvitamins: 0, percent: 0 };
    o.selenium = { nutrient_id: 317, value: 55, unit: "ug", name: "Selenium, Se", totalvitamins: 0, percent: 0 };
    o.sodium = { nutrient_id: 307, value: 1500, unit: "mg", name: "Sodium, Na", totalvitamins: 0, percent: 0 };
    o.vitaminA = { nutrient_id: 318, value: 3000, unit: "iu", name: "Vitamin A, IU", totalvitamins: 0, percent: 0 };
    o.vitaminB = { nutrient_id: 415, value: 1.3, unit: "mg", name: "Vitamin B-6", totalvitamins: 0, percent: 0 };
    o.vitaminC = { nutrient_id: 325, value: 90, unit: "mg", name: "Vitamin C, total ascorbic acid", totalvitamins: 0, percent: 0 };
    o.vitaminD = { nutrient_id: 324, value: 15, unit: "ug", name: "Vitamin D", totalvitamins: 0, percent: 0 };
    o.vitaminE = { nutrient_id: 323, value: 22.4, unit: "iu", name: "Vitamin E (alpha-tocopherol)", totalvitamins: 0, percent: 0 };
    o.zinc = { name: "Zinc, Zn", unit: "mg", nutrient_id: 301, value: 11, totalvitamins: 0, percent: 0 };
    o.savedmeal = {};

    o.getlist = function () {
        var config = { contextType: 'application/json' };
        var defer = $q.defer();
        $http.get('/api/apiList/' + o.mealID, config).success(function (data) {
            defer.resolve(data);
            o.yourfood.length = 0;
            o.yourfood = data;
        });
        return defer.promise;
    };

    o.addMeal = function (id, mealname) {
        var config = { contextType: 'application/json' };
        o.savedmeal.MealName = mealname;
        o.savedmeal.MealId = id;
        $http.post('/api/apiUser/', o.savedmeal, config).success(function (data) {
            alert("Meal Saved!");
        }).error(function (data, status) {
            console.log(data.status)
        });
    };
    o.delete = function (id) {
        var config = { contextType: 'application/json' };
        var defer = $q.defer();
        $http.delete('/api/apiTotals/' + id, config).success(function (data) {
            defer.resolve(data);
            console.log(o.vit);
            o.vit.length = length;
            for (i = 0; i < length; i++) {
                if (o.vit[i].dayid = id) {
                    o.vit.splice(i, 1);
                }
            };
            console.log(o.vit);
        }).error(function (data, status) {
            console.log(data, status)
        });
        return defer.promise;
    };
    o.DeleteTotals = function (id) {
        var defer = $q.defer();
        var config = { contextType: 'application/json' };
        $http.get('/api/apiDisplay/' + id, config).success(function (data) {
            defer.resolve(data);

            for (i = 0; i < data.length; i++) {
                switch (data[i].nutrient_id) {
                    case 301:
                        cal = o.calcium.totalvitamins - parseInt(data[i].totalvitamins);
                        o.calcium.totalvitamins = cal;
                        o.calcium.percent = o.calcium.percent - parseInt(data[i].percent)
                        break;

                    case 312:
                        cop = o.copper.totalvitamins - parseInt(data[i].totalvitamins);
                        o.copper.totalvitamins = cop;
                        o.copper.percent = o.copper.percent - parseInt(data[i].percent)
                        break;

                    case 313:

                        flu = o.fluoride.totalvitamins - parseInt(data[i].totalvitamins);
                        o.fluoride.totalvitamins = flu;
                        o.fluoride.percent = o.fluoride.percent - parseInt(data[i].percent)
                        break;

                    case 431:
                        fol = o.folic.totalvitamins - parseInt(data[i].totalvitamins);
                        o.folic.totalvitamins = fol;
                        o.folic.percent = o.folic.percent - parseInt(data[i].percent)
                        break;

                    case 303:
                        iro = o.iron.totalvitamins - parseInt(data[i].totalvitamins);
                        o.iron.totalvitamins = iro;
                        o.iron.percent = o.iron.percent - parseInt(data[i].percent)
                        break;

                    case 304:
                        o.magnesium.totalvitamins = o.magnesium.totalvitamins - parseInt(data[i].totalvitamins);
                        o.magnesium.percent = o.magnesium.percent - parseInt(data[i].percent)
                        break;

                    case 315:
                        o.manganese.totalvitamins = o.manganese.totalvitamins - parseInt(data[i].totalvitamins);
                        o.calcium.percent = o.calcium.percent - parseInt(data[i].percent)
                        break;

                    case 305:
                        o.phosphorus.totalvitamins = o.phosphorus.totalvitamins - parseInt(data[i].totalvitamins);
                        o.phosphorus.percent = o.phosphorus.percent - parseInt(data[i].percent)
                        break;

                    case 317:
                        o.selenium.totalvitamins = o.selenium.totalvitamins - parseInt(data[i].totalvitamins);
                        o.selenium.percent = o.selenium.percent - parseInt(data[i].percent)
                        break;

                    case 307:
                        o.sodium.totalvitamins = o.sodium.totalvitamins - parseInt(data[i].totalvitamins);
                        o.sodium.percent = o.sodium.percent - parseInt(data[i].percent)
                        break;

                    case 318:
                        o.vitaminA.totalvitamins = o.vitaminA.totalvitamins - parseInt(data[i].totalvitamins);
                        o.vitaminA.percent = o.vitaminA.percent - parseInt(data[i].percent)
                        break;

                    case 415:
                        o.vitaminB.totalvitamins = o.vitaminB.totalvitamins - parseInt(data[i].totalvitamins);
                        o.vitaminB.percent = o.vitaminB.percent - parseInt(data[i].percent)
                        break;

                    case 325:
                        o.vitaminC.totalvitamins = o.vitaminC.totalvitamins - parseInt(data[i].totalvitamins);
                        o.vitaminC.percent = o.vitaminC.percent - parseInt(data[i].percent)
                        break;

                    case 324:
                        o.vitaminD.totalvitamins = o.vitaminD.totalvitamins - parseInt(data[i].totalvitamins);
                        o.vitaminD.percent = o.vitaminD.percent - parseInt(data[i].percent)
                        break;

                    case 323:
                        o.vitaminE.totalvitamins = o.vitaminE.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminE.percent = o.vitaminE.percent - parseInt(data[i].percent)
                        break;

                    case 309:
                        o.zinc.totalvitamins = o.zinc.totalvitamins - parseInt(data[i].totalvitamins);
                        o.zinc.percent = o.zinc.percent - parseInt(data[i].percent)
                        break;
                };
            };

            o.rec.length = 0;
            o.rec.push(o.calcium);
            o.rec.push(o.copper);
            o.rec.push(o.fluoride);
            o.rec.push(o.folic);
            o.rec.push(o.iron);
            o.rec.push(o.magnesium);
            o.rec.push(o.manganese);
            o.rec.push(o.phosphorus);
            o.rec.push(o.selenium);
            o.rec.push(o.sodium);
            o.rec.push(o.vitaminA);
            o.rec.push(o.vitaminB);
            o.rec.push(o.vitaminC);
            o.rec.push(o.vitaminD);
            o.rec.push(o.vitaminE);
            o.rec.push(o.zinc);
        }).error(function (data, status) {
            console.log(data, status);
        });

        return defer.promise;
    };
    o.getTotals = function () {
        var defer = $q.defer();
        var config = { contextType: 'application/json' };
        $http.get('/api/apiTotals/' + o.mealID, config).success(function (data) {
            defer.resolve(data);
            o.vit.length = 0;
            for (i = 0; i < data.length; i++) {
                switch (data[i].nutrient_id) {
                    case 301:
                        cal = o.calcium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.calcium.totalvitamins = cal;
                        o.calcium.percent = o.calcium.percent + parseInt(data[i].percent)
                        console.log(o.calcium.totalvitamins)
                        break;

                    case 312:
                        cop = o.copper.totalvitamins + parseInt(data[i].totalvitamins);
                        o.copper.totalvitamins = cop;
                        o.copper.percent = o.copper.percent + parseInt(data[i].percent)
                        break;

                    case 313:

                        flu = o.fluoride.totalvitamins + parseInt(data[i].totalvitamins);
                        o.fluoride.totalvitamins = flu;
                        o.fluoride.percent = o.fluoride.percent + parseInt(data[i].percent)
                        break;

                    case 431:
                        fol = o.folic.totalvitamins + parseInt(data[i].totalvitamins);
                        o.folic.totalvitamins = fol;
                        o.folic.percent = o.folic.percent + parseInt(data[i].percent)
                        break;

                    case 303:
                        iro = o.iron.totalvitamins + parseInt(data[i].totalvitamins);
                        o.iron.totalvitamins = iro;
                        o.iron.percent = o.iron.percent + parseInt(data[i].percent)
                        break;

                    case 304:
                        o.magnesium.totalvitamins = o.magnesium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.magnesium.percent = o.magnesium.percent + parseInt(data[i].percent)
                        break;

                    case 315:
                        o.manganese.totalvitamins = o.manganese.totalvitamins + parseInt(data[i].totalvitamins);
                        o.calcium.percent = o.calcium.percent + parseInt(data[i].percent)
                        break;

                    case 305:
                        o.phosphorus.totalvitamins = o.phosphorus.totalvitamins + parseInt(data[i].totalvitamins);
                        o.phosphorus.percent = o.phosphorus.percent + parseInt(data[i].percent)
                        break;

                    case 317:
                        o.selenium.totalvitamins = o.selenium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.selenium.percent = o.selenium.percent + parseInt(data[i].percent)
                        break;

                    case 307:
                        o.sodium.totalvitamins = o.sodium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.sodium.percent = o.sodium.percent + parseInt(data[i].percent)
                        break;

                    case 318:
                        o.vitaminA.totalvitamins = o.vitaminA.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminA.percent = o.vitaminA.percent + parseInt(data[i].percent)
                        break;

                    case 415:
                        o.vitaminB.totalvitamins = o.vitaminB.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminB.percent = o.vitaminB.percent + parseInt(data[i].percent)
                        break;

                    case 325:
                        o.vitaminC.totalvitamins = o.vitaminC.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminC.percent = o.vitaminC.percent + parseInt(data[i].percent)
                        break;

                    case 324:
                        o.vitaminD.totalvitamins = o.vitaminD.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminD.percent = o.vitaminD.percent + parseInt(data[i].percent)
                        break;

                    case 323:
                        o.vitaminE.totalvitamins = o.vitaminE.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminE.percent = o.vitaminE.percent + parseInt(data[i].percent)
                        break;

                    case 309:
                        o.zinc.totalvitamins = o.zinc.totalvitamins + parseInt(data[i].totalvitamins);
                        o.zinc.percent = o.zinc.percent + parseInt(data[i].percent)
                        break;
                };
            };
            o.rec.length = 0;
            o.rec.push(o.calcium);
            o.rec.push(o.copper);
            o.rec.push(o.fluoride);
            o.rec.push(o.folic);
            o.rec.push(o.iron);
            o.rec.push(o.magnesium);
            o.rec.push(o.manganese);
            o.rec.push(o.phosphorus);
            o.rec.push(o.selenium);
            o.rec.push(o.sodium);
            o.rec.push(o.vitaminA);
            o.rec.push(o.vitaminB);
            o.rec.push(o.vitaminC);
            o.rec.push(o.vitaminD);
            o.rec.push(o.vitaminE);
            o.rec.push(o.zinc);
            console.log(o.rec);
        }).error(function (data, status) {
            console.log(data, status);
        });
        return defer.promise;
    };
    //get totals by id
    o.getTotals = function () {
        var defer = $q.defer();
        var config = { contextType: 'application/json' };
        $http.get('/api/apiTotals/' + o.mealID, config).success(function (data) {
            defer.resolve(data);
            o.vit.length = 0;
            o.vit = data;
            for (i = 0; i < data.length; i++) {
                switch (data[i].nutrient_id) {
                    case 301:
                        cal = o.calcium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.calcium.totalvitamins = cal;
                        o.calcium.percent = o.calcium.percent + parseInt(data[i].percent)
                        break;

                    case 312:
                        cop = o.copper.totalvitamins + parseInt(data[i].totalvitamins);
                        o.copper.totalvitamins = cop;
                        o.copper.percent = o.copper.percent + parseInt(data[i].percent)
                        break;

                    case 313:

                        flu = o.fluoride.totalvitamins + parseInt(data[i].totalvitamins);
                        o.fluoride.totalvitamins = flu;
                        o.fluoride.percent = o.fluoride.percent + parseInt(data[i].percent)
                        break;

                    case 431:
                        fol = o.folic.totalvitamins + parseInt(data[i].totalvitamins);
                        o.folic.totalvitamins = fol;
                        o.folic.percent = o.folic.percent + parseInt(data[i].percent)
                        break;

                    case 303:
                        iro = o.iron.totalvitamins + parseInt(data[i].totalvitamins);
                        o.iron.totalvitamins = iro;
                        o.iron.percent = o.iron.percent + parseInt(data[i].percent)
                        break;

                    case 304:
                        o.magnesium.totalvitamins = o.magnesium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.magnesium.percent = o.magnesium.percent + parseInt(data[i].percent)
                        break;

                    case 315:
                        o.manganese.totalvitamins = o.manganese.totalvitamins + parseInt(data[i].totalvitamins);
                        o.calcium.percent = o.calcium.percent + parseInt(data[i].percent)
                        break;

                    case 305:
                        o.phosphorus.totalvitamins = o.phosphorus.totalvitamins + parseInt(data[i].totalvitamins);
                        o.phosphorus.percent = o.phosphorus.percent + parseInt(data[i].percent)
                        break;

                    case 317:
                        o.selenium.totalvitamins = o.selenium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.selenium.percent = o.selenium.percent + parseInt(data[i].percent)
                        break;

                    case 307:
                        o.sodium.totalvitamins = o.sodium.totalvitamins + parseInt(data[i].totalvitamins);
                        o.sodium.percent = o.sodium.percent + parseInt(data[i].percent)
                        break;

                    case 318:
                        o.vitaminA.totalvitamins = o.vitaminA.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminA.percent = o.vitaminA.percent + parseInt(data[i].percent)
                        break;

                    case 415:
                        o.vitaminB.totalvitamins = o.vitaminB.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminB.percent = o.vitaminB.percent + parseInt(data[i].percent)
                        break;

                    case 325:
                        o.vitaminC.totalvitamins = o.vitaminC.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminC.percent = o.vitaminC.percent + parseInt(data[i].percent)
                        break;

                    case 324:
                        o.vitaminD.totalvitamins = o.vitaminD.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminD.percent = o.vitaminD.percent + parseInt(data[i].percent)
                        break;

                    case 323:
                        o.vitaminE.totalvitamins = o.vitaminE.totalvitamins + parseInt(data[i].totalvitamins);
                        o.vitaminE.percent = o.vitaminE.percent + parseInt(data[i].percent)
                        break;

                    case 309:
                        o.zinc.totalvitamins = o.zinc.totalvitamins + parseInt(data[i].totalvitamins);
                        o.zinc.percent = o.zinc.percent + parseInt(data[i].percent)
                        break;
                };
            };
            o.rec.push(o.calcium);
            o.rec.push(o.copper);
            o.rec.push(o.fluoride);
            o.rec.push(o.folic);
            o.rec.push(o.iron);
            o.rec.push(o.magnesium);
            o.rec.push(o.manganese);
            o.rec.push(o.phosphorus);
            o.rec.push(o.selenium);
            o.rec.push(o.sodium);
            o.rec.push(o.vitaminA);
            o.rec.push(o.vitaminB);
            o.rec.push(o.vitaminC);
            o.rec.push(o.vitaminD);
            o.rec.push(o.vitaminE);
            o.rec.push(o.zinc);
        }).error(function (data, status) {
            console.log(data, status);
        });
        return defer.promise;
    };

    //creates new totals for recommened vitamins
    o.add = function (food, vit) {
        var defer = $q.defer();

        if (food == null) {
            alert('Please pick a food first!');
        }
        else {
            for (i = 0; i < food.nutrients.length; i++) {
                food.nutrients[i].food = food.name;
            }
            for (i = 0; i < vit.length; i++) {
                food.nutrients.push(vit[i]);
            }
            var config = { contextType: 'application/json' };
            $http.post('/api/apiFood/', food.nutrients, config).success(function (data) {
                $http.get('/api/apiTotals/', config).success(function (data) {
                    defer.resolve(data);
                    o.mealID = data;
                })
            }).error(function (data, status) {
                console.log(data, status);
            });
        };
        return defer.promise;
        o.getTotals();
    };

    return o;
}]);