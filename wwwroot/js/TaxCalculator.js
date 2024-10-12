const incomeInput = document.getElementById("income");
    incomeInput.addEventListener("input", function (e) {
        let value = e.target.value.replace(/,/g, ''); // Remove existing commas
    if (!isNaN(value) && value) {
        e.target.value = Number(value).toLocaleString(); // Add commas
        }
    });

