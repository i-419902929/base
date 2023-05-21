(function () {
    // controller volo.abp.identity.identityUser

    (function () {

        abp.utils.createNamespace(window, 'volo.abp.auditlogging.auditlog');
        volo.abp.auditlogging.auditlog.getAuditLogs = function (input, ajaxParams) {
            return abp.ajax($.extend(true, {
                url: abp.appPath + 'api/auditlogging/auditlog/GetAuditLogs' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
                type: 'GET'
            }, ajaxParams));
        };

    })();

})();


