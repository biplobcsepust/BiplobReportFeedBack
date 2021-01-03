var app = angular.module("myApp", []);
        app.controller("reportCtrl", function ($scope, $http) {

            var vm = $scope
            vm.title = "working";
            vm.data = [];
            init();
            function init() {
        loadData();
            }

            function loadData(search = '', page = 1, pageSize = 3) {
        $http.get("http://localhost:5000/api/post?search=" + search + "&page=" + page + "&pageSize=" + pageSize).then(function (result) {
            vm.data = result.data;
        }, function (err) {
            console.log(err);
        })
    }

            function _setVote(vote) {
        $http({
            method: 'PUT',
            url: 'http://localhost:5000/api/common',
            data: vote
        }).then(function (result) {

        }, function (err) {
            console.log(err);
        });

            }



            vm.onSearch = function search() {
        loadData(vm.search);
            }
            vm.onPrev = function () {
        loadData(vm.search, vm.data.pageIndex - 1);
            };
            vm.onNext = function () {
        loadData(vm.search, vm.data.pageIndex + 1);
            };
            vm.like = function (comment) {
                var vote = {id: comment.id, like: ++comment.like, disLike: comment.dislike };
                _setVote(vote);
            }
            vm.dislike = function (comment) {
                var vote = {id: comment.id, like: comment.like, disLike: ++comment.dislike };
                _setVote(vote);
            }
        });