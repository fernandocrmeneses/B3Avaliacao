const PROXY_CONFIG = [
  {
    context: [
        'api/',
    ],
    target: "https://localhost:44386/api/",
    secure: false,
    changeOrigin: true,
    pathRewrite: {
      "^/":""
    }
  }
]

module.exports = PROXY_CONFIG;
