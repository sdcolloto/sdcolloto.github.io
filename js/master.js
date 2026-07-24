function loadInclude(id, file) {
  fetch(file)
    .then(response => response.text())
    .then(html => document.getElementById(id).innerHTML = html);
}

loadInclude("navbar", "navbar.html");
loadInclude("footer", "footer.html");
