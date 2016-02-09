//Add Employee Form Validation
function validateForm() {
    var emailRegex = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
    var dateRegex = /(\d{4})[-\/](\d{2})[-\/](\d{2})/;
    var mobilRegex = /0([1-9][0-9])-([0-9]){7}/;
    var nicRegex = /[1-9]([0-9]){8}[a-z]/;


    if (document.myForm.firstName.value == "") {
        bootstrap_alert.warning("Please provide your first name!");
        document.myForm.firstName.focus();
        return false;
    }
    if (document.myForm.lastName.value == "") {
        bootstrap_alert.warning("Please provide your last name!");
        document.myForm.lastName.focus();
        return false;
    }
    if (document.myForm.streetAddress.value == "") {
        bootstrap_alert.warning("Please provide your Street Address! e.g : N0 232/5 Madiwella Rd");
        document.myForm.streetAddress.focus();
        return false;
    }
    if (document.myForm.city.value == "") {
        bootstrap_alert.warning("Please provide your City! e.g : Colombo");
        document.myForm.city.focus();
        return false;
    }
    if ((document.myForm.mobileNumber.value == "") || !(mobilRegex.test(document.myForm.mobileNumber.value))) {
        bootstrap_alert.warning("Please provide your Mobile Number! Format : 0XX-XXXXXXX");
        document.myForm.mobileNumber.focus();
        return false;
    }
    if ((document.myForm.nicNumber.value == "") || !(nicRegex.test(document.myForm.nicNumber.value))) {
        bootstrap_alert.warning("Please provide your NIC Number! Format : XXXXXXXXXv");
        document.myForm.nicNumber.focus();
        return false;
    }
    //|| (emailRegex.test(document.myForm.email.value))
    if ((document.myForm.email.value == "") || !(emailRegex.test(document.myForm.email.value))) {
        bootstrap_alert.warning("Please provide your Email! Format : user@example.com");
        document.myForm.email.focus();
        return false;
    }
    if ((document.myForm.birthDate.value == "") || !(dateRegex.test(document.myForm.birthDate.value))) {
        bootstrap_alert.warning("Please provide your Date of Birth! Format : yyyy/mm/dd");
        document.myForm.birthDate.focus();
        return false;
    }
}