const http = require('http');

const server = http.createServer(function (req, res) {
    const url = req.url;

    // eslint-disable-next-line default-case
    switch (url) {
        case "/":
            res.writeHead(200, { 'Content-Type': 'text/html' })
            res.write("<h1>Ana Sayfa</h1>")
            res.end()
            break;
        case "/about":
            res.writeHead(200, { 'Content-Type': 'text/html' })
            res.write("Hakkimda")
            res.end()
            break;
        case "/contact":
            res.writeHead(200, { 'Content-Type': 'text/html' })
            res.write("Iletisim")
            res.end()
            break;

        default:
            res.writeHead(404, { "Content-Type": "text/html" })
            res.write("<h1>404 Page is not found</h1>")
            break;
    }
})

const port = 5000;

server.listen(port, function () {
    console.log(`Sunucu ${port} portundan başlatıldı.`)
})