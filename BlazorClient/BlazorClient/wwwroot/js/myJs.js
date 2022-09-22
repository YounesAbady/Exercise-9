$('InputTextArea.resize').each(function () {
    this.setAttribute('style', 'height:' + (this.scrollHeight) + 'px;overflow-y:hidden;');
}).on('input', function () {
    this.style.height = 'auto';
    this.style.height = (this.scrollHeight) + 'px';
}).on('mousemove', function () {
    this.style.height = 'auto';
    this.style.height = (this.scrollHeight) + 'px';
}).on('keyup', function (event) {
    if (event.which === 9) {
        this.style.height = 'auto';
        this.style.height = (this.scrollHeight) + 'px';
    }
});

function close() {
    var items = document.getElementsByClassName("close-modal");
    for (let i = 0; i < items.length; i++) {
        items[i].click();
    }

}