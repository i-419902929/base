$(function () {
    var l = abp.localization.getResource('AbpAuditLogging');
    
    var dataTable = $('#AuditLogTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[2, "desc"]],
            searching: false,
            scrollX: true,
            scrollY: "58vh",
            ajax: abp.libs.datatables.createAjax(volo.abp.auditlogging.auditlog.getAuditLogs),
            columnDefs: [
                { 
                    data: null,
                    orderable: false,
                    defaultContent: '',
                    rowAction: {
                        element: $("<div/>")
                            .addClass("text-center")
                            .append($("<button/>")
                                .addClass("btn btn-default btn-xs")
                                .attr("title", l("AuditLogDetail"))
                                .append($("<i/>").addClass("fa fa-search"))
                            ).click(function () {
                                showDetails($(this).data());
                            })
                    }
                },
                {                  
                    data: "exception",
                    orderable: false,
                    render: function (exception) {
                        var $div = $("<div/>").addClass("text-center");
                        if (exception) {
                            $div.append($("<i/>").addClass("fa fa-warning font-yellow-gold").attr("title",l("HasError")));
                        } else {
                            $div.append($("<i/>").addClass("fa fa-check-circle font-green").attr("title", l("Success")));
                        }

                        return $div[0].outerHTML;
                    }
                },
                {
                    title: l('Time'),                  
                    data: "executionTime"
                },
                {
                    title: l('UserName'),  
                    data: "userName"
                },
                {
                    title: l('ApplicationName'),  
                    data: "applicationName"
                },
                {
                    title: l('HttpMethod'),  
                    data: "httpMethod"
                },
                {
                    title: l('Duration'),  
                    data: "executionDuration",
                    render: function (executionDuration) {
                        return l('Xms', executionDuration);
                    }
                },
                {
                    title: l('IpAddress'),  
                    data: "clientIpAddress",
                    orderable: false
                },
                {
                    title: l('ClientName'),  
                    data: "clientName"
                },
                {
                    title: l('BrowserInfo'),  
                    data: "browserInfo"
                }
            ]
        })
    );
});
