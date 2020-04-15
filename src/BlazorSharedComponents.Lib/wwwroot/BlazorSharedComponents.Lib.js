// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.exampleJsFunctions = {
  showPrompt: function (message) {
    return prompt(message, 'Type anything here');
  }
};

function addStaticAssets()
{
    var head = document.createElement('div');
    head.innerHTML = '<link href="_content/MatBlazor/dist/matBlazor.css" rel="stylesheet" />';
    while (head.firstChild) {
        document.getElementsByTagName('head')[0].appendChild(head.firstChild);
    }

    var body = document.createElement('div');
    body.innerHTML = '<script src="_content/MatBlazor/dist/matBlazor.js"></script>';
    while (body.firstChild) {
        document.getElementsByTagName('body')[0].appendChild(body.firstChild);
    }
}