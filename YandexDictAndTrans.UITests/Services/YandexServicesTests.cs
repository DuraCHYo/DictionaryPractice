using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace YandexDictAndTrans.UI.Services.Tests
{
  [TestClass()]
  public class YandexServicesTests
  {
    // Переводчик
    [TestMethod()]
    public async Task GetTranslateAnswerAsyncTest()
    {
      // Проверочный класс для переводчика
      // Объявлем переменную ru на русский язык
      var ru = "семь раз отмерь один раз отрежь";
      // Объявлем переменную eng на английский язык
      var eng = "measure twice cut once\r\n";
      YandexServices sut = new YandexServices();
      YandexServices.TranslationDirection direction
          = YandexServices.TranslationDirection.RuEng;

      YandexAnswer answer = await sut.GetTranslateAnswerAsync(ru, direction);

      Assert.AreEqual("OK", answer.Code);
      Assert.AreEqual(eng, answer.Text);
    }
    // Словарь
    [TestMethod()]
    public async Task GetDictionaryAnswerAsyncTest()
    {
      var ru = "мысль";
      var eng = "thought";
      YandexServices sut = new YandexServices();
      YandexServices.TranslationDirection direction
          = YandexServices.TranslationDirection.RuEng;

      YandexAnswer answer = await sut.GetDictionaryAnswerAsync(ru, direction);

      Assert.AreEqual("OK", answer.Code);
      Assert.IsTrue(answer.Text.Contains(eng));
    }
  }
}