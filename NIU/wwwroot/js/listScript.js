let apiUrl = "https://localhost:44355/api/rovers";
let mainElmnt = document.querySelector('.niu-main');
let nasaApiUrl = "https://api.nasa.gov/mars-photos/api/v1/rovers/spirit/photos?sol=1000&api_key=DEMO_KEY";

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

const createCards = async () => {
    const data = await fetchData(apiUrl);

    for (let i = 0; i < data.length; i++) {
        let cardDiv = customCreateElement("div", "class", "card", mainElmnt);
        cardDiv.style.width = "18rem";

        let img = customCreateElement("img", "src", "images/" + data[i].name + ".jpg", cardDiv);
        img.setAttribute("class", "card-img-top");

        let cardBody = customCreateElement("div", "class", "card-body", cardDiv);

        let cardTitle = customCreateElement("h5", "class", "card-title", cardBody);
        cardTitle.textContent = data[i].name

        let cardText = customCreateElement("p", "class", "card-text", cardBody);
        cardText.textContent = data[i].description;

        let cardBtn = customCreateElement("a", "class", "btn", cardBody);
        cardBtn.setAttribute("href", "Rovers/Details/" + data[i].name);
        cardBtn.classList.add("btn-primary");
        cardBtn.textContent = "Läs mer";
    }
}

createCards();