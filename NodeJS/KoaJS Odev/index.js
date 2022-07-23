const Koa = require('koa');
const app = new Koa();

// response
app.use(ctx => {

    switch (ctx.url) {
        case '/':
            ctx.body = "Home Page";
            break;
        case '/about':
            ctx.body = "About Page";
            break;

        default:
            ctx.body = "404 Not Found";
            break;
    }


});

app.listen(3000);