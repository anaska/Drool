function AddCurrency(name) {
    PageMethods.AddCurrency(name, OnSuccess, OnFailure);
}
function OnSuccess(value) {
    //var x = document.getElementById('list');
    //var entry = document.createElement('li');
    //entry.appendChild(document.createTextNode(value));
    //x.appendChild(entry);
    alert(value);

}
function OnFailure(error) {
    alert(error);
}