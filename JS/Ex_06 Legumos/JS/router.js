const route = (event) => {
    event = event || window.event;
    event.preventDefault();
    window.history.pushState({}, "", event.target.href);
    handleLocation();
};

const routes = {
    "/vegetables": "/html/vegetables.html",
    "/sells": "/html/sells.html",
    "/newSells": "/html/newSells.html",
    "/newVegetables": "/html/newVegetables.html",
};

const handleLocation = async () => {
    const path = window.location.pathname;
    const route = routes[path];
    const html = await fetch(route).then((data) => data.text());
    document.getElementById("main-page").innerHTML = html;
};

window.onpopstate += handleLocation;
window.route = route;

handleLocation();
