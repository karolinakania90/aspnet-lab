(function () {
    const alertElement = document.getElementById("success-alert");
    const errorElement = document.getElementById("error-alert");

    const formElement = document.forms[0];
    const addNewItem = async () => {

        // 1. read data from the form
        const requestData = JSON.stringify({ Name: document.getElementById("Name").value, Description: document.getElementById("Description").value, IsVisible: document.getElementById("IsVisible").checked });

        // 2. call the application server using fetch method

        const url = "/api/item/new";
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: requestData
        });

        const responseJson = await response.json();

        if (responseJson.success) {
            alertElement.style.display = "block";
            errorElement.style.display = "none";
        }
        else {
            alertElement.style.display = "none";
            errorElement.style.display = "block";
        }
        return responseJson;
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            alertElement.style.display = "none";
            addNewItem().then((result) => {
                if (result.success) {
                    console.log("added successfully")
                }
                else {
                    console.log("cannot add item");
                }
            });
        });
    });
})();