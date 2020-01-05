const request = require('request');
const connectDb = require("./context");
const repository = require('./repository');

const config = {
    url: 'https://api.github.com/users/tarcisio-marinho/repos',
    json: true,
    headers: {
        'User-Agent': 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36'
    }
}

request(config, (err, res, body) => {
    if (err) { return console.log(err); }
    body.sort(function (a, b) {
        return b.stargazers_count - a.stargazers_count;
    });

    body.forEach(repository => {
        console.log(repository.stargazers_count, repository.name)
    });

    getRepos(body);
});

async function getRepos(data) {
    connectDb().then(() => {
        console.log("MongoDb connected");
        const resp = repository.insertMany(data);
        console.log(resp);
    });
}
