const router = require('express').Router()
const Music = require('../models/music.schema')
const MusicMatrix = require('../models/music.matrix.schema')

router.get('/', async (req, res) => {
    const music = await Music.find({})
    res.send(music)
})

router.get('/post', async (req, res) => {
    const music = new Music({
        name: 'ds',
        Image: 'asjdh',
        Link: 'asjdh'
    })
    await music.save()
    res.send(music)
})

router.get('/:id', async (req, res) => {
    const book = await Music.findById(req.params.id)
    res.send(book)
})

router.get('/:id/recommend', async (req, res) => {
    const book = await Music.findById(req.params.id)

    for (let i = 1; i < 11; i++) {
        const matrix = await MusicMatrix.findOne({ [i]: book.name })
        if (matrix[1]) {
            const booksNameRecommend = Object.values(matrix.toObject())
            const recommends = await Music.find({
                name: { $in: booksNameRecommend }
            })
            console.log(recommends)
            res.send(recommends)
        }
    }
})

module.exports = router