
(function ($) {
    $.fn.textSearch = function (str, options) {
        var defaults = {
            divFlag: true,
            divStr: " ",
            markClass: "",
            markColor: "yellow",
            nullReport: true,
            callback: function () {
                return false;
            }
        };
        var sets = $.extend({}, defaults, options || {}), clStr;
        if (sets.markClass) {
            clStr = "class='" + sets.markClass + "'";
        } else {
            clStr = "style='padding:0;margin:0;color:" + sets.markColor + ";'";
        }

        //对前一次高亮处理的文字还原		
        $("span[rel='mark']").each(function () {
            var text = document.createTextNode($(this).text());
            $(this).replaceWith($(text));
        });


        //字符串正则表达式关键字转化
        $.regTrim = function (s) {
            var imp = /[\^\.\\\|\(\)\*\+\-\$\[\]\?]/g;
            var imp_c = {};
            imp_c["^"] = "\\^";
            imp_c["."] = "\\.";
            imp_c["\\"] = "\\\\";
            imp_c["|"] = "\\|";
            imp_c["("] = "\\(";
            imp_c[")"] = "\\)";
            imp_c["*"] = "\\*";
            imp_c["+"] = "\\+";
            imp_c["-"] = "\\-";
            imp_c["$"] = "\$";
            imp_c["["] = "\\[";
            imp_c["]"] = "\\]";
            imp_c["?"] = "\\?";
            s = s.replace(imp, function (o) {
                return imp_c[o];
            });
            return s;
        };
        $(this).each(function () {
            var t = $(this);
            str = $.trim(str);
            if (str === "") {
                return false;
            } else {
                var arr = [];
                if (sets.divFlag) {
                    arr = str.split(sets.divStr);
                } else {
                    arr.push(str);
                }
            }
            var v_html = t.html();
            v_html = v_html.replace(/<!--(?:.*)\-->/g, "");

            var tags = /[^<>]+|<(\/?)([A-Za-z]+)([^<>]*)>/g;
            var a = v_html.match(tags), test = 0;
            $.each(a, function (i, c) {
                if (!/<(?:.|\s)*?>/.test(c)) {
                    $.each(arr, function (index, con) {
                        if (con === "") { return; }
                        var reg = new RegExp($.regTrim(con), "gi");
                        if (reg.test(c)) {
                            var r = c.match(reg);
                            c = c.replace(r, "♂" + r + "♀");
                            test = 1;
                        }
                    });
                    c = c.replace(/♂/g, "<span rel='mark' " + clStr + ">").replace(/♀/g, "</span>");
                    a[i] = c;
                }
            });
            var new_html = a.join("");

            $(this).html(new_html);

            if (test === 0 && sets.nullReport) {
                return false;
            }

            sets.callback();
        });
    };
})(jQuery);