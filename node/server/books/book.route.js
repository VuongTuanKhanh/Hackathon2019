const router = require('express').Router()
const Book = require('../models/book.schema')
const BookMatrix = require('../models/book.matrix.schema')

router.get('/', async (req, res) => {
    const books = await Book.find({})
    books.length = 12
    res.send(books)
})

router.get('/:id', async (req, res) => {
    const book = await Book.findOne({ book_id: req.params.id })
    res.send(book)
})

router.get('/:id/recommend', async (req, res) => {
    const book = await Book.findOne({ book_id: req.params.id })

    for (let i = 1; i < 21; i++) {
        const matrix = await BookMatrix.findOne({ [i]: book.name })
        if (matrix[1]) {
            const booksNameRecommend = Object.values(matrix.toObject())
            const recommends = await Book.find({
                title: { $in: booksNameRecommend }
            })
            res.send(recommends)
        }
    }
})

module.exports = router