(function () {
    'use strict';

    angular.module('boilerplate')
        .factory('nakamaService', NakamaService);

    NakamaService.$inject = ['$http', 'webApiUrl'];
    function NakamaService($http, webApiUrl) {
        return {
            getNakama: function (nakamaId) {
                return $http.get((webApiUrl + "api/nakama"), {
                    params: {
                        nakamaId: nakamaId
                    }
                });
            },
            listNamaka: function () {
                return $http.get((webApiUrl + "api/nakama/all"));
            }
        };
    }
})();