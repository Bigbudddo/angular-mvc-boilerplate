(function () {
    'use strict';

    angular
        .module('boilerplate', [
            'angular.filter',
            'moment-picker',
            'ngAnimate',
            'ngAria',
            'ngCookies',
            'ngMessages',
            'ngSanitize',
            'ui.router'
        ])
        .config(CookieConfiguration)
        .config(HttpConfiguration)
        .constant('webApiUrl', 'http://localhost:57574/');;

    //////////////////////////////////////////
    // App base Configuration
    //////////////////////////////////////////
    CookieConfiguration.$inject = ['$cookiesProvider'];
    function CookieConfiguration($cookiesProvider) {
        $cookiesProvider.defaults.path = '/';
    }

    HttpConfiguration.$inject = ['$httpProvider'];
    function HttpConfiguration($httpProvider) {
        $httpProvider.interceptors.push('httpRequestInterceptor');
        $httpProvider.defaults.transformResponse.push(function (responseData) {
            if (responseData != null) {
                // we need to check for our own HTTP Result
                if (responseData.hasOwnProperty('Result')) {
                    window.top.formatDateStringsToDates(responseData.Result);
                }
                else {
                    // handles basic/default returns/http-requests
                    window.top.formatDateStringsToDates(responseData);
                }
            }

            return responseData;
        });
    }
})();