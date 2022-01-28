let mainElmnt = document.querySelector(".niu-main");
let roverName = document.querySelector(".hidden-input");
let nasaApiUrl = "https://api.nasa.gov/mars-photos/api/v1/rovers/" + roverName.value + "/photos?sol=1000&page=1&api_key=SndjkFVduJhT02KRPLEJtZOr252PuDF4y21IQ1aI";
let apiUrl = "https://localhost:44355/api/rovers/" + roverName.value;

customCreateElement = (tag, attribute, attributeName, parent) => {
    element = document.createElement(tag);
    if (attribute) {
        element.setAttribute(attribute, attributeName);
    }
    parent.appendChild(element);
    return element;
}

const fetchData = async (url) => {
    const response = await fetch(url);
    const data = await response.json();
    return data;
}

const createView = async () => {
    const dataNasa = await fetchData(nasaApiUrl);
    const data = await fetchData(apiUrl);

    createCarousel(dataNasa.photos);
    console.log(data);
    createInfo(data);
}

const createCarousel = (images) => {
    let carouselDiv = customCreateElement("div", "id", "carouselExampleIndicators", mainElmnt);
    carouselDiv.setAttribute("class", "carousel");
    carouselDiv.classList.add("slide");
    carouselDiv.setAttribute("data-bs-ride", "carousel");

    let indicatorDiv = customCreateElement("div", "class", "carousel-indicators", carouselDiv);

    for (let i = 0; i < images.length; i++) {
        let exampleBtn = customCreateElement("button", "type", "button", indicatorDiv);
        exampleBtn.setAttribute("data-bs-slide-to", i);
        exampleBtn.setAttribute("data-bs-target", "#carouselExampleIndicators");
        exampleBtn.setAttribute("aria-label", "Slide " + (i + 1));

        if (i === 0) {
            exampleBtn.setAttribute("class", "active");
            exampleBtn.setAttribute("aria-current", "true");
        }
    }

    let innerDiv = customCreateElement("div", "class", "carousel-inner", carouselDiv);

    for (let i = 0; i < images.length; i++) {
        let itemDiv = customCreateElement("div", "class", "carousel-item", innerDiv);

        let image = customCreateElement("img", "class", "d-block", itemDiv);
        image.classList.add("w-100");
        image.setAttribute("src", images[i].img_src);

        if (i === 0) {
            itemDiv.classList.add("active");
        }
    }

    // Prev button
    let btnCtrlPrev = customCreateElement("button", "type", "button", carouselDiv);
    btnCtrlPrev.setAttribute("class", "carousel-control-prev");
    btnCtrlPrev.setAttribute("data-bs-target", "#carouselExampleIndicators");
    btnCtrlPrev.setAttribute("data-bs-slide", "prev");

    let prevIconSpan = customCreateElement("span", "class", "carousel-control-prev-icon", btnCtrlPrev);
    prevSpan = customCreateElement("span", "class", "visually-hidden", btnCtrlPrev);
    prevSpan.textContent = "Föregående";

    // Next button
    let btnCtrlNext = customCreateElement("button", "type", "button", carouselDiv);
    btnCtrlNext.setAttribute("class", "carousel-control-next");
    btnCtrlNext.setAttribute("data-bs-target", "#carouselExampleIndicators");
    btnCtrlNext.setAttribute("data-bs-slide", "next");

    let nextIconSpan = customCreateElement("span", "class", "carousel-control-next-icon", btnCtrlNext);
    nextSpan = customCreateElement("span", "class", "visually-hidden", btnCtrlNext);
    nextSpan.textContent = "Nästa";
}

const createInfo = (data) => {
    let rowDl = customCreateElement("dl", "class", "row", mainElmnt);

    // Beskrivning
    let dt = customCreateElement("dt", "class", "col-sm-3", rowDl);
    dt.innerText = "Beskrivning";

    let dd = customCreateElement("dd", "class", "col-sm-9", rowDl);
    dd.innerText = data.description;

    // Länk
    dt = customCreateElement("dt", "class", "col-sm-3", rowDl);
    dt.innerText = "Länk";

    link = customCreateElement("a", "class", "col-sm-9", rowDl);
    link.innerText = data.nasaUrl;
    link.setAttribute("href", data.nasaUrl);

    // Historia
    dt = customCreateElement("dt", "class", "col-sm-3", rowDl);
    dt.innerText = "Historia";

    dd = customCreateElement("dd", "class", "col-sm-9", rowDl);
    dd.innerText = data.history;

    // Vikt
    dt = customCreateElement("dt", "class", "col-sm-3", rowDl);
    dt.innerText = "Vikt";

    dd = customCreateElement("dd", "class", "col-sm-9", rowDl);
    dd.innerText = data.weight;

    // Hjul
    dt = customCreateElement("dt", "class", "col-sm-3", rowDl);
    dt.innerText = "Antal hjul";

    dd = customCreateElement("dd", "class", "col-sm-9", rowDl);
    dd.innerText = data.numberOfWheels;
}

createView();