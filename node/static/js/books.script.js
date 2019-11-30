function LatestBook(book) {
    document.cookie = `lastId=${book.book_id}`
    const recentBooks = JSON.parse(localStorage.getItem('recentBooks'))
    recentBooks.pop()
    recentBooks.push(book)
    localStorage.setItem('recentBooks', JSON.stringify(recentBooks))
    window.location.href = '/product-virtual.html'
}

async function getBooks() {
    const res = await fetch('http://localhost:3000/books')
    const json = await res.json()
    console.log(document.getElementsByClassName("primary-image")[4])

    for (let i = 0; i < document.getElementsByClassName("product-name").length; i++) {
        document.getElementsByClassName("product-name")[i].childNodes[0].textContent = json[i].title;
        document.getElementsByClassName("new-price")[i].textContent = Math.floor(Math.random() * 100) + "$";
        document.getElementsByClassName("primary-image")[i].src = json[i].image_url
        document.getElementsByClassName("secondary-image")[i].src = json[i].image_url
        document.getElementsByClassName("secondary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("secondary-image")[i].style.width = "100%"
        document.getElementsByClassName("secondary-image")[i].style.height = "275px"
        document.getElementsByClassName("primary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("primary-image")[i].style.width = "100%"
        document.getElementsByClassName("primary-image")[i].style.height = "275px"
        document.getElementsByClassName("product-content")[i].style.height = "80px"
        document.getElementsByClassName("product-name")[i].addEventListener("click", function(){ LatestBook(json[i])} )
    }
}
