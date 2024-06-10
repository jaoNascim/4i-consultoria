window.clipboardCopy = {
  copyEmail: function (text) {
    navigator.clipboard.writeText(text).then(function () {
      console.log('Email copiado para o clipboard.');
    })
      .catch(function (error) {
        console.error('Erro: ', error);
      });
  },
  copyPhone: function (text) {
    navigator.clipboard.writeText(text).then(function () {
      console.log('Telefone copiado para o clipboard.');
    })
      .catch(function (error) {
        console.error('Erro: ', error);
      });
  }
};

function scrollToTop() {
  window.scrollTo(0, 0);
}