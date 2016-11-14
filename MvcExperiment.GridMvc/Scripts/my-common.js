var $window = $(window);
var $body = $('body, html');

/**
 * 文字列からパラメータの配列を作成して返す
 * @param {string} str 文字列
 * @return {array} パラメータ配列
 */
function getVars(str) {
    var vars = [], hash;

    if (str.indexOf('=') > 0) { 
        hashes = str.slice(str.indexOf('?') + 1).split('&');


        for (var i = 0; i < hashes.length; i++) {
            hash = hashes[i].split('=');

            vars[hash[0]] = hash[1];
        }
    }

    return vars;
}

/**
 * 配列をパラメータの文字列に変換して返す
 * @param {array} array パラメータ配列
 * @return {string} 文字列
 */
function getStrParameter(array) {
    var amp = "", str = "";
    for (var key in array) {
        str += amp + key + "=" + array[key];
        amp = "&";
    }

    return str;
}

/**
 * ローディング表示を切り替える
 * @param {bool} sw 切替スイッチbool
 */
function toggleBlockLoading(sw) {
    var selector = 'blockLoading';
    if (sw) {
        $('<div id="' + selector + '"></div>').css({
            zIndex: 2000,
            position: 'fixed',
            top: 0,
            left: 0,
            right: 0,
            bottom: 0,
            background: '#fff',
            cursor: 'wait',
            opacity: 0.3
        }).appendTo('body');
    } else {
        $('#' + selector).remove();
    }
}