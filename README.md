## StackEditWorkspaceConverter
특정 디렉토리를 스택에딧 워크스페이스로 임포트 가능한 .json 파일 형태로 변환해주는 프로그램

### 사용법
```
StackEditWorkspaceConverter.exe <target directory> <export file>
```
* taget directory : 변환할 파일 폴더가 있는 디렉토리 경로
* export file : 결과가 저장될 파일


### 예시
```
./StackEditWorkspaceConverter.exe "C:\my directory" "C:\output.json"
```

#### 디렉토리 예시
- C:\
   - my directory
      - test folder
         - hello.md
      - file.md

#### 실제 변환되었을 때
- test folder
   - hello
- file