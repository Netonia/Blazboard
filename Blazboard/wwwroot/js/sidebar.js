(() => {
    'use strict'

    document.addEventListener("DOMContentLoaded", function () {
        const toggleButton = document.querySelector("#sidebar-toggle");
        const sidebar = document.querySelector("#sidebar");

        if (toggleButton && sidebar) {
            toggleButton.addEventListener("click", function () {
                sidebar.classList.toggle("collapsed");
            });
        }
    });
})();
//(() => {
//    'use strict'

//    /* Siderbar */
//    /* https://github.com/codzsword/bootstrap-admin-dashboard */

//    document.querySelector("#sidebar-toggle").addEventListener("click", function () {
//        document.querySelector("#sidebar").classList.toggle("collapsed");
//    });

//})()