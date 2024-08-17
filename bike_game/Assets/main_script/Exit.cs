using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // 이 메서드는 버튼에 연결될 것입니다.
    public void Quit()
    {
        // 유니티 에디터에서 실행할 때는 실제 종료가 안되므로 로그를 출력
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

        // 로그 출력
        Debug.Log("Game is quitting...");
    }
}