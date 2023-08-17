document.addEventListener("DOMContentLoaded", function () {
    function addEmployee() {
        var empNo = document.getElementById("EmpNo").value;
        var firstName = document.getElementById("FirstName").value;
        var lastName = document.getElementById("LastName").value;
        var birthdate = document.getElementById("Birthdate").value;
        var contactNo = document.getElementById("ContactNo").value;
        var emailAddress = document.getElementById("EmailAddress").value;

        $.post('@Url.Action("InsertEmployee", "Employee")', {
            EmpNo: empNo,
            FirstName: firstName,
            LastName: lastName,
            Birthdate: birthdate,
            ContactNo: contactNo,
            EmailAddress: emailAddress
        }).done(function () {
            alert("Employee added successfully!");
        }).fail(function () {
            alert("Failed to add employee.");
        });
    }

    var addButton = document.getElementById("yourButtonId"); 
    addButton.onclick = addEmployee;
});
