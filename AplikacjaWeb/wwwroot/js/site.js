// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function asyncComm() {
    const xml = new XMLHttpRequest()
    xml.onloadend = (e) => {
        if (xml.status === 200) {
            document.querySelector('textarea[name="content"]').value = xml.responseText
            console.log(document.querySelector('textarea[name="content"]'))
        }
    }
    xml.open("POST", "Contact?Handler=Submit")
    xml.setRequestHeader('RequestVerificationToken', document.querySelector('input[name="__RequestVerificationToken"]').value);
    xml.send()
}

function eventMaintance() {
    document.querySelector(".button").onclick = function (e) { alert("TO JA"); asyncComm(); }
}
