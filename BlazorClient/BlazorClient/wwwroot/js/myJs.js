function close() {
    var items = document.getElementsByClassName("close-modal");
    for (let i = 0; i < items.length; i++) {
        items[i].click();
    }
}
function toast() {
    const toastLiveExample = document.getElementById('liveToast');
    const toast = new bootstrap.Toast(toastLiveExample);
    toast.show();
}