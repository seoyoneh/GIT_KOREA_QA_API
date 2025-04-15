# 서연이화 초중품 관리 APP API 서비스

## 프로젝트 소개
이 프로젝트는 서연이화의 초중품 관리를 위한 모바일 애플리케이션의 백엔드 API 서비스입니다.

## 기술 스택
- .NET Core
- C#
- JWT 인증
- Swagger API 문서화

## 주요 기능
- 사용자 인증 및 권한 관리
- 파일 업로드 서비스
- 검사(Inspection) 관리
- JWT 기반 보안

## 프로젝트 구조
```
├── Controllers/     # API 컨트롤러
├── Services/        # 비즈니스 로직 서비스
├── Repositories/    # 데이터 접근 계층
├── Models/          # 데이터 모델
├── Entity/         # 데이터베이스 엔티티
├── Filters/        # API 필터
├── Middleware/     # 미들웨어 컴포넌트
├── Utils/          # 유틸리티 클래스
├── Exceptions/     # 예외 처리
└── Helper/         # 헬퍼 클래스
```

## 환경 설정
프로젝트는 다음 환경 설정을 지원합니다:
- Development
- Staging
- Production

각 환경에 대한 설정은 `appsettings.[Environment].json` 파일에서 관리됩니다.

## API 문서
API 문서는 Swagger를 통해 제공됩니다. 개발 환경에서 실행 시 `/swagger` 엔드포인트에서 확인할 수 있습니다.

## 인증
JWT(JSON Web Token) 기반의 인증 시스템을 사용합니다. 모든 보호된 엔드포인트에 대해 유효한 JWT 토큰이 필요합니다.

## 시작하기
1. 프로젝트 클론
```bash
git clone [repository-url]
```

2. 의존성 설치
```bash
dotnet restore
```

3. 프로젝트 실행
```bash
dotnet run
```

## API 명세서
### 로그인(협력사)
```
http://<host>:<port>/api/Auth/login
```
#### 요청(Request)
| 파라미터 | 데이터타입 | Required | Example |
|--------|----------|--------|-------|
| username | string | Y | 1001000 |
| password | string | Y | 0000 |
| isVendor | boolean | Y | true |
| langSet | string | N | KO |

#### 응답(Response)
| Key | 데이터타입 | Required | Example |
|---|----------|-------|-------|
| activeToken | string | Y | eyJhbGciO..... |
| refreshToken | string | Y | eyJhbGciOi.... |
| expiresAt | DateTime | Y | 2025-04-15T07:23:56.932502Z |

## 라이선스
이 프로젝트는 서연이화의 독점 소프트웨어입니다.
