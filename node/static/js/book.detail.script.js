async function chayFunc() {
    const getCookie = (name) => {
        return document.cookie.split('; ').reduce((r, v) => {
            const parts = v.split('=')
            return parts[0] === name ? decodeURIComponent(parts[1]) : r
        }, '')
    }
    const lastId = getCookie('lastId')
    const res1 = await fetch(`http://localhost:3000/books/${lastId}`)
    const res2 = await fetch(`http://localhost:3000/books/${lastId}/recommend`)
    const data = await Promise.all([res1, res2])
    const json1 = await data[0].json()
    const json2 = await data[1].json()

    document.getElementById("book-img").src = json1.image_url
    document.getElementById("book-img").style.width = "200px"
    document.getElementById("book-img").style.height = "280px"

    const primaryImage = document.getElementsByClassName('primary-image')
    const productName = document.getElementsByClassName('product-name')
    const recentBooks = JSON.parse(localStorage.getItem('recentBooks'))
    console.log(recentBooks)

    for (let i=0; i<4; i++) {
        primaryImage[i].src = json2[i].image_url
        productName[i].childNodes[0].textContent = json2[i].title
        document.getElementsByClassName("secondary-image")[i].src = json2[i].image_url
    }
}