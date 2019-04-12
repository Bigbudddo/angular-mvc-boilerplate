(function () {
    'use strict';

    angular
        .module('boilerplate')
        .controller('siteController', SiteController)
        .controller('dashboardController', DashboardController)
        .controller('nakamaController', NakamaController);

    SiteController.$inject = ['$scope', '$state'];
    function SiteController($scope, $state) {
        //////////////////////////////////////////
        // Properties
        //////////////////////////////////////////
        $scope.windowTitle = "AngularMVC - Boilerplate";

        //////////////////////////////////////////
        // 'Constructor'
        //////////////////////////////////////////
        $scope.init = function (viewbag) {
            // note; wrapped in an if incase it re-calls this init function
            // todo; we might need to figure out why this fires when section pages jump
            if (typeof (viewbag) === 'object') {
                // store the viewbag/data parameters in our session to be used by our state provider later
                sessionStorage.setItem('ud', JSON.stringify(viewbag));

                // set the window title if we are overriding the base title
                if (typeof (viewbag['win_title']) === 'string') {
                    $scope.windowTitle = viewbag['win_title'];
                }

                // decide what base/parent view/state we want to show
                if (typeof (viewbag['state'] === 'string')) {
                    $state.go(viewbag['state'], {}, { reload: true });
                }
                else {
                    console.error('unable to navigation to base state as it has not been provided!');
                }
            }
        }
    }

    DashboardController.$inject = ['$scope', '$timeout', 'nakamaService'];
    function DashboardController($scope, $timeout, nakamaService) {

        
    }

    NakamaController.$inject = ['$scope', '$timeout', 'nakamaService'];
    function NakamaController($scope, $timeout, nakamaService) {

        $scope.nakama = [];
        $scope.isLoading = true;

        this.$onInit = function () {
            nakamaService.listNamaka().then(s => {
                $timeout(function () {
                    console.log('fetched the data', s);

                    $scope.nakama = s.data;
                    $scope.isLoading = false;
                }, 150);
            }, e => {
                console.error('there was a problem fetching the nakama!', e);
            });
        }

        $scope.convertMoney = function (money) {
            return window.top.formatMoney(money, 0);
        }
    }
})();