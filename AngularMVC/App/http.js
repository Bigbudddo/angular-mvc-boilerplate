(function () {
    'use strict';

    angular.module('boilerplate').factory('httpRequestInterceptor', HttpRequestInterceptor);

    HttpRequestInterceptor.$inject = ['webApiUrl'];
    function HttpRequestInterceptor(webApiUrl) {
        return {
            request: function (config) {
                // so we only want to push these headers when we are going to our web-api
                if (config.url.startsWith(webApiUrl)) {
                    config.headers['Authorization'] = 'Basic <<TOKEN HERE>>';
                    config.headers['Accept'] = 'application/json;odata=verbose';
                }

                return config;
            }
        }
    }
})();