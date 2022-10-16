using UnityEngine ;
using EasyUI.PickerWheelUI ;
using UnityEngine.UI ;
using TMPro;
using System.Collections;
public class Demo : MonoBehaviour {
   [SerializeField] private Button uiSpinButton ;
   [SerializeField] private TMP_Text uiSpinButtonText ;
                    public TMP_Text text_result;
   [SerializeField] private PickerWheel pickerWheel ;
   [SerializeField] private WheelPiece wheelPiece;
                    public GameObject WheelScreen;
                    public GameObject WorkPanel;


   public void Start () {
      text_result.text = "วันนี้จะเกิดเหตุการณ์อะไรในการทำงานของคุณลองหมุนวงล้อเสี่ยงโชคดูสิ!";
      uiSpinButton.onClick.AddListener (() => {
        
         uiSpinButton.interactable = false ;
         uiSpinButtonText.text = "กำลังหมุน";
         
         pickerWheel.OnSpinStart(()=>{
            Debug.Log("Spin start");

         });

         pickerWheel.OnSpinEnd (wheelPiece => {
            Debug.Log (
               @" <b>Index:</b> " + wheelPiece.Index + "           <b>Label:</b> " + wheelPiece.Label
               + "\n <b>Amount:</b> " + wheelPiece.Amount + "      <b>Chance:</b> " + wheelPiece.Chance + "%"
            ) ;
   
            uiSpinButton.interactable = true ;
            uiSpinButtonText.text = "ลองหมุน" ;
            text_result.text = wheelPiece.Label ;
             StartCoroutine(ExampleCoroutine());
            WheelScreen.SetActive(false);
            WorkPanel.SetActive(true);
         }) ;


         pickerWheel.Spin ();

      }) ;

   }
       IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(5);

   
    }

}
