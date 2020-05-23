using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YandexDictAndTrans.UI.API;

namespace YandexDictAndTrans.UI.ViewModel
{
  public class MainViewModel
  {
    private YandexServices _yandexServices;

    public MainViewModel(YandexServices yandexServices)
    {
      //Оператор nameof получает имя, тип или член переменной в качестве строковой константы
      _yandexServices = yandexServices ??
            throw new ArgumentNullException(nameof(yandexServices));

      //свойста класса List<>
      Langs = new List<string>() { "Русский - Английский", "Английский - Русский" };
    }

    public event EventHandler OutputChanged;

    private string _Output;
    public string Output
    {
      get { return _Output; }
      set {
        _Output = value;
        OutputChanged.Invoke(this, EventArgs.Empty);
      }
    }
    //Автоматическое определение свойств для методов
    public string Input { get; set; }

    public List<string> Langs { get; }

    public int SelectedLang { get; set; }

    //получение данных с переводчика
    public async Task GetTransationAsync()
    {
      var direction = GetDirection();
      var result = await _yandexServices
          .GetTranslateAnswerAsync(Input, direction);

      Output = result.Text;
    }
    // получение данных со словаря
    public async Task GetDictionaryAsync()
    {
      var direction = GetDirection();
      var result = await _yandexServices.GetDictionaryAnswerAsync(Input, direction);

      Output = result.Text;
    }
    // Проверка на язык программы
    private YandexServices.TranslationDirection GetDirection()
    {
      if (SelectedLang == 0)
      {
        return YandexServices.TranslationDirection.RuEng;
      }
      else
      {
        return YandexServices.TranslationDirection.EngRu;
      }
    }
  }
}
