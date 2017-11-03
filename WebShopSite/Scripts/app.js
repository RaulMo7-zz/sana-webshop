$(document).ready(function () {
    $(function () {
        /*var myBtn = document.getElementById('btnSubmit');  
        myBtn.addEventListener('click', function(e) {  
            e.preventDefault();  
            alert('Hello');  
        });*/
        if (!Cookies.get('storageType'))
            Cookies.set('storageType', 'db');

        setNameStorage(Cookies.get('storageType'));
        $('#btnSwitchStorage').click(function (event) {
            event.preventDefault();
            Cookies.set("storageType", Cookies.get('storageType') === 'db' ? "memory" : 'db');
            setNameStorage(Cookies.get('storageType'));
            //$.ajax({
            //    // edit to add steve's suggestion.
            //    //url: "/ControllerName/ActionName",
            //    url: 'Products/Index',
            //    success: function (data) {
            //        // your data could be a View or Json or what ever you returned in your action method 
            //        // parse your data here
            //    }
            //});
            //document.location = 'Products/Index';
            var arrayPathLocation = document.location.pathname.split('/');
            var lastArrayElem = arrayPathLocation[arrayPathLocation.length - 1];
            if (lastArrayElem === 'Products' || lastArrayElem === 'Index' || lastArrayElem === '')
                document.location.reload();
            //            alert(document.location.protocol + '//' +
            //document.location.host +
            //document.location.pathname);
        });

        function setNameStorage(selectedStorage) {
            $('#btnSwitchStorage').text(selectedStorage === 'db' ? 'Switch Storage to Memory' : 'Switch Storage to Database');
        }
    });
});