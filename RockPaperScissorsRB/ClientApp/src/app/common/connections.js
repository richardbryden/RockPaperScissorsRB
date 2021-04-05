"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Connections = void 0;
var rxjs_1 = require("rxjs");
var Connections = /** @class */ (function () {
    function Connections(http) {
        this.http = http;
        this.baseURL = '/api/';
    }
    Connections.prototype.getResult = function (pvc, playerChoice, scoreP1, scoreP2, scoreTie) {
        var _this = this;
        return rxjs_1.Observable.create(function (observer) {
            observer.next(null);
            var pvcString = String(pvc);
            var url = _this.baseURL + "Get/" + pvcString + "/" + playerChoice + "/" + scoreP1 + "/" + scoreP2 + "/" + scoreTie;
            _this.http.get(url).subscribe(function (data) {
                observer.next(data);
                observer.complete();
            }, function (error) {
                observer.error(error);
            });
        });
    };
    return Connections;
}());
exports.Connections = Connections;
//# sourceMappingURL=connections.js.map