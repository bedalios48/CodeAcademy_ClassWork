const paymentForm = document.querySelector("payment");
console.log(paymentForm);

paymentForm.addEventListener("submit", submitPayment(event));

function submitPayment(event) {
    event.preventDefault();
    const inputs = event.target.elements;
    console.log(inputs);
}